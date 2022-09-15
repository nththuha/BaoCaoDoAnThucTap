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
import com.example.ordermanagement.adapter.KitchenAdapter
import com.example.ordermanagement.databinding.FragmentBartenderBinding
import com.example.ordermanagement.model.OrderDetailEntity
import com.example.ordermanagement.viewmodel.BartenderViewModel
import com.google.android.material.switchmaterial.SwitchMaterial

class BartenderFragment : Fragment() {
    private val viewModel: BartenderViewModel by activityViewModels()

    private var _binding: FragmentBartenderBinding? = null
    private val binding get() = _binding!!

    private var adapter: KitchenAdapter? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setHasOptionsMenu(true)
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentBartenderBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        adapter = KitchenAdapter { it, num ->
            when (num) {
                1 -> suaChiTietDatMon(it, "doing")
                2 -> suaChiTietDatMon(it, "done")
                else -> xoaChiTietDatMon(it)
            }
        }
        Thread.sleep(1000)
        loadDSCTDM()
        binding.apply {
            rvOrderKC.adapter = adapter

            srOrderKC.setOnRefreshListener {
                loadDSCTDM()
                srOrderKC.isRefreshing = false
            }
        }
    }

    private fun suaChiTietDatMon(detail: OrderDetailEntity, trangThai: String) {
        viewModel.suaCT_DatMon(
            OrderDetailEntity(
                detail.idCTDM,
                detail.soLuong,
                detail.chuThich,
                trangThai,
                detail.gia,
                detail.maMA,
                detail.tenMA,
                detail.maLMA,
                detail.idPD,
                detail.tenPhong,
                detail.tenBan
            )
        )
        Thread.sleep(1000)
        Toast.makeText(context, "Order detail has changed status", Toast.LENGTH_SHORT).show()
        loadDSCTDM()
    }

    private fun xoaChiTietDatMon(detail: OrderDetailEntity) {
        showDialogConfirm(detail)
    }

    private fun showDialogConfirm(ctdm: OrderDetailEntity) {
        val dialog = Dialog(requireActivity())
        dialog.requestWindowFeature(Window.FEATURE_NO_TITLE)
        dialog.setContentView(R.layout.dialog_delete_detail_switch)

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

        val btnCancel = dialog.findViewById<Button>(R.id.btnCancel_DES)
        btnCancel.setOnClickListener {
            dialog.dismiss()
        }

        val btnConfirm = dialog.findViewById<Button>(R.id.btnConfirm_DES)
        btnConfirm.setOnClickListener {
            val s = viewModel.xoaCT_DatMon(ctdm.idCTDM)

            val switch = dialog.findViewById<SwitchMaterial>(R.id.swMonAn)
            if (switch.isChecked) {
                viewModel.suaTrangThaiMonAn(ctdm.maMA)
            }
            Thread.sleep(1000L)
            if (s) showMessage("Delete order details successfully")
            else showMessage("Delete failed details")
            loadDSCTDM()
            dialog.dismiss()
        }
        dialog.show()
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
        viewModel.layDSDatMon_NuocUong().observe(viewLifecycleOwner) { dsCTDM ->
            dsCTDM.let {
                adapter?.submitList(it)
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
        val action = BartenderFragmentDirections.actionBartenderFragmentToLoginFragment()
        view?.findNavController()?.navigate(action)
    }
}