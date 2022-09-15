package com.example.ordermanagement.ui

import android.app.Dialog
import android.graphics.Color
import android.graphics.drawable.ColorDrawable
import android.os.Bundle
import android.view.*
import android.widget.Button
import android.widget.TextView
import android.widget.Toast
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import com.example.ordermanagement.R
import com.example.ordermanagement.adapter.OrderDetailAdapter
import com.example.ordermanagement.databinding.FragmentDetailBinding
import com.example.ordermanagement.model.OrderDetailEntity
import com.example.ordermanagement.viewmodel.RestaurantViewModel

class DetailFragment : Fragment() {
    private val viewModel: RestaurantViewModel by activityViewModels()

    private var _binding: FragmentDetailBinding? = null
    private val binding get() = _binding!!

    private var adapter: OrderDetailAdapter? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setHasOptionsMenu(true)
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        _binding = FragmentDetailBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        adapter = OrderDetailAdapter { it, num ->
            if (num == 1) {
                if (it.maLMA == "LMA11") {
                    showDialogConfirm(it)
                } else if (it.trangThai == "doing" || it.trangThai == "done")
                    showMessage("You cannot cancel this order details")
                else {
                    showDialogConfirm(it)
                }
            } else {
                if (it.trangThai == "just order" || it.maLMA == "LMA11") {
                    dialog(it)
                } else {
                    Toast.makeText(
                        context,
                        "You can not edit this detail order!",
                        Toast.LENGTH_SHORT
                    ).show()
                }
            }
        }
        loadDSCTDM()
        binding.rvOrder.adapter = adapter
        binding.srOrder.setOnRefreshListener {
            loadDSCTDM()
            binding.srOrder.isRefreshing = false
        }
    }

    private fun showDialogConfirm(ctdm: OrderDetailEntity) {
        val dialog = Dialog(requireActivity())
        dialog.requestWindowFeature(Window.FEATURE_NO_TITLE)
        dialog.setContentView(R.layout.dialog_delete_detail)

        val window: Window? = dialog.window
        window?.setLayout(
            WindowManager.LayoutParams.MATCH_PARENT,
            WindowManager.LayoutParams.WRAP_CONTENT
        )
        window?.setBackgroundDrawable(ColorDrawable(Color.TRANSPARENT))

        val windowAttributes: WindowManager.LayoutParams = window!!.attributes
        windowAttributes.gravity = Gravity.CENTER
        window.attributes = windowAttributes
        //click ra bên ngoài để tắt dialog -> false = no; true = yes
        dialog.setCancelable(true)

        val btnCancel = dialog.findViewById<Button>(R.id.btnCancel_DE)
        btnCancel.setOnClickListener {
            dialog.dismiss()
        }

        val btnConfirm = dialog.findViewById<Button>(R.id.btnConfirm_DE)
        btnConfirm.setOnClickListener {
            xoaCTDM(ctdm)
            dialog.dismiss()
        }
        dialog.show()
    }

    private fun xoaCTDM(ctdm: OrderDetailEntity) {
        val s = viewModel.xoaCT_DatMon(ctdm.idCTDM)
        if (s) showMessage("Delete order detail successfully")
        else showMessage("Delete failed booking details")
        loadDSCTDM()
    }

    private fun showMessage(message: String) {
        val dialog = Dialog(requireActivity())
        dialog.requestWindowFeature(Window.FEATURE_NO_TITLE)
        dialog.setContentView(R.layout.dialog_message)

        val window: Window? = dialog.window
        window?.setLayout(
            WindowManager.LayoutParams.MATCH_PARENT,
            WindowManager.LayoutParams.WRAP_CONTENT
        )
        window?.setBackgroundDrawable(ColorDrawable(Color.TRANSPARENT))

        val windowAttributes: WindowManager.LayoutParams = window!!.attributes
        windowAttributes.gravity = Gravity.CENTER
        window.attributes = windowAttributes
        //click ra bên ngoài để tắt dialog -> false = no; true = yes
        dialog.setCancelable(true)
        val tvMes = dialog.findViewById<TextView>(R.id.tvMessage)
        tvMes.text = message

        val btnConfirm = dialog.findViewById<Button>(R.id.btnConfirm_MS)
        btnConfirm.setOnClickListener {
            dialog.dismiss()
        }
        dialog.show()
    }

    private fun loadDSCTDM() {
        viewModel.layDSDatMonTheoPD().observe(viewLifecycleOwner) { dsCTDM ->
            adapter?.submitList(dsCTDM)
        }
    }

    private fun dialog(m: OrderDetailEntity) {
        val dialog = Dialog(requireActivity())
        dialog.requestWindowFeature(Window.FEATURE_NO_TITLE)
        dialog.setContentView(R.layout.dialog_detail)

        val window: Window? = dialog.window
        window?.setLayout(
            WindowManager.LayoutParams.MATCH_PARENT,
            WindowManager.LayoutParams.WRAP_CONTENT
        )
        window?.setBackgroundDrawable(ColorDrawable(Color.TRANSPARENT))

        val windowAttributes: WindowManager.LayoutParams = window!!.attributes
        windowAttributes.gravity = Gravity.CENTER
        window.attributes = windowAttributes
        //click ra bên ngoài để tắt dialog
        //false = no; true = yes
        dialog.setCancelable(true)

        val tvTenMon = dialog.findViewById<TextView>(R.id.tvTenMon_Dialog)
        tvTenMon.text = m.tenMA

        val tvAmount = dialog.findViewById<TextView>(R.id.etAmount)
        tvAmount.text = m.soLuong.toString()

        val btnCancel = dialog.findViewById<Button>(R.id.btnCancel)
        btnCancel.setOnClickListener {
            dialog.dismiss()
        }

        val btnConfirm = dialog.findViewById<Button>(R.id.btnConfirm)
        btnConfirm.setOnClickListener {
            if (tvAmount.text.trim().toString() == "") {
                Toast.makeText(context, "Amount can not be blank", Toast.LENGTH_SHORT).show()
            } else {
                val soLuong = tvAmount.text.trim().toString().toIntOrNull()
                if (soLuong!! <= 0) {
                    Toast.makeText(context, "Amount must be greater than 0", Toast.LENGTH_SHORT)
                        .show()
                } else {
                    val temp = OrderDetailEntity(
                        m.idCTDM,
                        soLuong,
                        m.chuThich,
                        m.trangThai,
                        m.gia / m.soLuong * soLuong,
                        m.maMA,
                        m.tenMA,
                        m.maLMA,
                        m.idPD,
                        m.tenPhong,
                        m.tenBan
                    )
                    viewModel.suaCT_DatMon(temp)

                    Thread.sleep(1000)
                    Toast.makeText(context, "Edit successfully", Toast.LENGTH_SHORT).show()
                    loadDSCTDM()
                    dialog.dismiss()
                }
            }
        }
        dialog.show()
    }

    override fun onDestroy() {
        super.onDestroy()
        _binding = null
    }

    override fun onCreateOptionsMenu(menu: Menu, inflater: MenuInflater) {
        inflater.inflate(R.menu.menu, menu)
        super.onCreateOptionsMenu(menu, inflater)
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        if (item.itemId == R.id.btnDangXuat) {
            showDialog()
        }
        if (item.itemId == R.id.btnTrangChu) {
            val action = DetailFragmentDirections.actionDetailFragmentToTicketReservationFragment()
            view?.findNavController()?.navigate(action)
        }
        return super.onOptionsItemSelected(item)
    }

    private fun showDialog() {
        val dialog = Dialog(requireActivity())
        dialog.requestWindowFeature(Window.FEATURE_NO_TITLE)
        dialog.setContentView(R.layout.dialog_logout)

        val window: Window? = dialog.window
        window?.setLayout(
            WindowManager.LayoutParams.MATCH_PARENT,
            WindowManager.LayoutParams.WRAP_CONTENT
        )
        window?.setBackgroundDrawable(ColorDrawable(Color.TRANSPARENT))

        val windowAttributes: WindowManager.LayoutParams = window!!.attributes
        windowAttributes.gravity = Gravity.CENTER
        window.attributes = windowAttributes
        //click ra bên ngoài để tắt dialog -> false = no; true = yes
        dialog.setCancelable(true)

        val btnCancel = dialog.findViewById<Button>(R.id.btnCancel_QS)
        btnCancel.setOnClickListener {
            dialog.dismiss()
        }

        val btnConfirm = dialog.findViewById<Button>(R.id.btnConfirm_QS)
        btnConfirm.setOnClickListener {
            goBack()
            dialog.dismiss()
        }
        dialog.show()
    }

    private fun goBack() {
        viewModel.reset()
        val action = DetailFragmentDirections.actionDetailFragmentToLoginFragment()
        view?.findNavController()?.navigate(action)
    }
}