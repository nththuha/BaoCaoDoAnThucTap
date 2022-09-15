package com.example.ordermanagement.ui

import android.os.Bundle
import android.os.Handler
import android.util.Log
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.core.content.ContentProviderCompat.requireContext
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import com.example.ordermanagement.databinding.FragmentLoginBinding
import com.example.ordermanagement.model.NhanVienEntity
import com.example.ordermanagement.model.TaiKhoanEntity
import com.example.ordermanagement.network.RestaurantApi
import com.example.ordermanagement.viewmodel.BartenderViewModel
import com.example.ordermanagement.viewmodel.KitchenViewModel
import com.example.ordermanagement.viewmodel.RestaurantViewModel
import com.google.android.material.dialog.MaterialAlertDialogBuilder
import kotlinx.coroutines.*

class LoginFragment : Fragment() {
    companion object {
        const val MESSAGE: String = "MESSAGE"
        const val FOODRUNNER: String = "Food runner"
        const val RECEPTIONIST: String = "Receptionist"
        const val CHEF: String = "Chef"
        const val BARTENDER: String = "Bartender"
    }

    private val viewModel: RestaurantViewModel by activityViewModels()

    private val vm: KitchenViewModel by activityViewModels()

    private val v: BartenderViewModel by activityViewModels()

    private var _binding: FragmentLoginBinding? = null
    private val binding get() = _binding!!

    private var nhanVien: NhanVienEntity =
        NhanVienEntity(1, "error", "error", "error", "error", "error", "error", "error")

    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        _binding = FragmentLoginBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        binding.apply {
            btnLogin.setOnClickListener {
                val account = txtAccount.text.toString().trim()
                val password = txtPassword.text.toString().trim()
                if (account == "" || password == "") showDialog(
                    MESSAGE,
                    "Account and Password cannot be blank!"
                )
                else {
                    btnLogin.isEnabled = false
                    val taiKhoan = TaiKhoanEntity(account, password)

                    nhanVien = viewModel.nhanVien
                    runBlocking {
                        try {
                            nhanVien = RestaurantApi.retrofitService.kiemTraDangNhap(taiKhoan)
                            Log.e("LoginFragment login", nhanVien.toString())
                        } catch (e: Exception) {
                            Log.e("LoginFragment", e.message.toString())
                        }
                    }

//                    Handler().postDelayed({
                    btnLogin.isEnabled = true
                    if (nhanVien.diaChi == "error") showDialog(
                        MESSAGE,
                        "Account and Password are not correct!"
                    )
                    else {
                        when (nhanVien.tenBP) {
                            FOODRUNNER -> {
                                viewModel.themNhanVien(nhanVien)
                                val action =
                                    LoginFragmentDirections.actionLoginFragmentToTicketReservationFragment()
                                view.findNavController().navigate(action)
                            }
                            CHEF -> {
                                vm.themNhanVien(nhanVien)
                                val action =
                                    LoginFragmentDirections.actionLoginFragmentToKitchenFragment()
                                view.findNavController().navigate(action)
                            }
                            RECEPTIONIST -> showDialog(
                                MESSAGE,
                                "You are not a food runner to log in"
                            )
                            BARTENDER -> {
                                v.themNhanVien(nhanVien)
                                val action =
                                    LoginFragmentDirections.actionLoginFragmentToBartenderFragment()
                                view.findNavController().navigate(action)
                            }
                            else -> showDialog(MESSAGE, "Account and Password are not correct!")
                        }
                    }
//                    }, 3000)
//                    Thread.sleep(3000);

                }
            }
        }
    }

    private fun showDialog(tittle: String, message: String) {
        MaterialAlertDialogBuilder(requireContext())
            .setTitle(tittle)
            .setMessage(message)
            .setCancelable(false)
            .setPositiveButton("OK") { _, _ -> }
            .show()
    }

    override fun onDestroy() {
        super.onDestroy()
        _binding = null
    }
}