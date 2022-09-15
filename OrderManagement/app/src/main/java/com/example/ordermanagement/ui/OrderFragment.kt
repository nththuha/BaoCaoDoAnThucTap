package com.example.ordermanagement.ui

import android.app.Dialog
import android.graphics.Color
import android.graphics.drawable.ColorDrawable
import android.os.Bundle
import android.os.Handler
import android.util.Log
import android.view.*
import android.widget.Button
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast
import androidx.core.net.toUri
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import coil.load
import com.example.ordermanagement.R
import com.example.ordermanagement.adapter.FoodAdapter
import com.example.ordermanagement.adapter.TypeOfFoodAdapter
import com.example.ordermanagement.databinding.FragmentOrderBinding
import com.example.ordermanagement.model.FoodEntity
import com.example.ordermanagement.model.OrderDetailEntity
import com.example.ordermanagement.viewmodel.RestaurantViewModel

class OrderFragment : Fragment() {
    private val viewModel: RestaurantViewModel by activityViewModels()

    private var _binding: FragmentOrderBinding? = null
    private val binding get() = _binding!!

    private var adapterTOF: TypeOfFoodAdapter? = null

    private var adapterF: FoodAdapter? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setHasOptionsMenu(true)
    }

    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentOrderBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        adapterTOF = TypeOfFoodAdapter() {
            viewModel.chonLoaiMonAn(it)
            loadDSMonAn()
            binding.rvFood.adapter = adapterF
            binding.tvTittleFood.text = viewModel.loaiMonAn.value?.tenLMA
        }
        loadDSLoaiMonAn()
        binding.apply {
            rvTypeOfFood.adapter = adapterTOF
            rvFood.adapter = adapterF

            val dividerItemDecoration = DividerItemDecoration(
                rvFood.context,
                LinearLayoutManager(requireContext()).orientation
            )
            rvFood.addItemDecoration(dividerItemDecoration)

            srTypeOfFood.setOnRefreshListener {
                loadDSLoaiMonAn()
                srTypeOfFood.isRefreshing = false
            }
            srFood.setOnRefreshListener {
                loadDSMonAn()
                srFood.isRefreshing = false
            }
        }
        adapterF = FoodAdapter() {
            viewModel.chonMonAn(it)
            if (it.trangThai == "In stock") dialog(it)
        }
    }

    private fun loadDSLoaiMonAn() {
        viewModel.layDSLoaiMonAn().observe(viewLifecycleOwner) { dsLMA ->
            dsLMA.let {
                adapterTOF?.submitList(dsLMA)
            }
        }
    }

    private fun loadDSMonAn() {
        viewModel.layDSMonAnTheoLoaiMonAn().observe(viewLifecycleOwner) { dsMA ->
            dsMA.let {
                adapterF?.submitList(dsMA)
            }
        }
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
            val action = OrderFragmentDirections.actionOrderFragmentToTicketReservationFragment()
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
        val action = OrderFragmentDirections.actionOrderFragmentToLoginFragment()
        view?.findNavController()?.navigate(action)
    }

    private fun dialog(m: FoodEntity) {
        val dialog = Dialog(requireActivity())
        dialog.requestWindowFeature(Window.FEATURE_NO_TITLE)
        dialog.setContentView(R.layout.dialog_order_food)

        val window: Window? = dialog.window
        window?.setLayout(
            WindowManager.LayoutParams.MATCH_PARENT,
            WindowManager.LayoutParams.WRAP_CONTENT
        );
        window?.setBackgroundDrawable(ColorDrawable(Color.TRANSPARENT))

        val windowAttributes: WindowManager.LayoutParams = window!!.attributes
        windowAttributes.gravity = Gravity.CENTER
        window.attributes = windowAttributes
        //click ra bên ngoài để tắt dialog
        //false = no; true = yes
        dialog.setCancelable(true)

        val ivHinhAnh = dialog.findViewById<ImageView>(R.id.ivHinhAnh_Dialog)
        m.hinhAnh.let {
            val imgUri = m.hinhAnh.toUri().buildUpon().scheme("https").build()
            ivHinhAnh.load(imgUri) {
                placeholder(R.drawable.loading_animation)
                error(R.drawable.ic_broken_image)
            }
        }

        val tvTenMon = dialog.findViewById<TextView>(R.id.tvTenMon_Dialog)
        tvTenMon.text = m.tenMA

        val btnCancel = dialog.findViewById<Button>(R.id.btnCancel)
        btnCancel.setOnClickListener {
            dialog.dismiss()
        }

        val btnConfirm = dialog.findViewById<Button>(R.id.btnConfirm)
        btnConfirm.setOnClickListener {
            val tvAmount = dialog.findViewById<TextView>(R.id.etSL)
            if (tvAmount.text.trim().toString() == "") {
                Toast.makeText(context, "Amount can not be blank", Toast.LENGTH_SHORT).show()
            } else {
                val soLuong = tvAmount.text.trim().toString().toIntOrNull()
                if (soLuong!! <= 0) {
                    Toast.makeText(context, "Amount must be greater than 0", Toast.LENGTH_SHORT)
                        .show()
                } else {
                    var chuThich: String? = null
                    if (dialog.findViewById<TextView>(R.id.etNote).text.trim()
                            .toString() != ""
                    ) chuThich = dialog.findViewById<TextView>(R.id.etNote).text.trim().toString()
                    val trangThai = "just order"
                    val idpd = viewModel.phieuDat.value?.idPD
                    val maMA = viewModel.monAn.value?.maMA
                    val tenMA = viewModel.monAn.value?.tenMA
                    val gia = viewModel.monAn.value?.gia?.times(soLuong)

                    val temp = viewModel.themCT_DatMon(
                        OrderDetailEntity(
                            -5,
                            soLuong,
                            chuThich,
                            trangThai,
                            gia!!,
                            maMA!!,
                            tenMA!!,
                            "",
                            idpd!!,
                            "",
                            ""
                        )
                    )
                    Log.e("check value", temp.toString())
//                    Handler().postDelayed({
                        Toast.makeText(context, "Order successfully", Toast.LENGTH_SHORT).show()
                        dialog.dismiss()
//                    }, 1500)
                }
            }
        }
        dialog.show()
    }
}