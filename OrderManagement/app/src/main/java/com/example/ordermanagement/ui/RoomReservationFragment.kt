package com.example.ordermanagement.ui

import android.app.Dialog
import android.graphics.Color
import android.graphics.drawable.ColorDrawable
import android.os.Bundle
import android.view.*
import android.widget.Button
import android.widget.Toast
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import com.example.ordermanagement.R
import com.example.ordermanagement.adapter.RoomAdapter
import com.example.ordermanagement.adapter.TableAdapter
import com.example.ordermanagement.databinding.FragmentRoomReservationBinding
import com.example.ordermanagement.model.TicketReservationEntity
import com.example.ordermanagement.viewmodel.RestaurantViewModel
import java.text.SimpleDateFormat
import java.util.*

class RoomReservationFragment : Fragment() {
    private val viewModel: RestaurantViewModel by activityViewModels()

    private var _binding: FragmentRoomReservationBinding? = null
    private val binding get() = _binding!!

    private var adapterR: RoomAdapter? = null

    private var adapterT: TableAdapter? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setHasOptionsMenu(true)
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        _binding = FragmentRoomReservationBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        adapterR = RoomAdapter {
            viewModel.chonPhong(it)
            loadDSBan()
            binding.rvTable.adapter = adapterT
            binding.tvTittleTable.text = "TABLE OF " + viewModel.phong.value?.tenPhong
        }
        loadDSPhong()
        binding.apply {
            rvRoom.adapter = adapterR
            srRoom.setOnRefreshListener {
                loadDSPhong()
                srRoom.isRefreshing = false
            }
            rvTable.adapter = adapterT
            srTable.setOnRefreshListener {
                loadDSBan()
                srTable.isRefreshing = false
            }
        }

        adapterT = TableAdapter {
            viewModel.chonBan(it)

            val sdf = SimpleDateFormat("yyyy-MM-dd")
            val currentDate = sdf.format(Date())
            val idnv = viewModel.nhanVien.idNV
            val maPhong = viewModel.phong.value?.maPhong
            val maBan = viewModel.ban.value?.maBan
            viewModel.themPhieuDat(
                TicketReservationEntity(
                    -5,
                    currentDate,
                    idnv,
                    maBan!!,
                    null,
                    maPhong!!,
                    null
                )
            )
//            Thread.sleep(1000)
            Toast.makeText(context, "Successfully", Toast.LENGTH_SHORT).show()
            val action =
                RoomReservationFragmentDirections.actionRoomReservationFragmentToOrderFragment()
            view.findNavController().navigate(action)
        }
    }

    private fun loadDSPhong() {
        viewModel.layDSPhong().observe(viewLifecycleOwner) { dsPhong ->
            dsPhong.let {
                adapterR?.submitList(dsPhong)
            }
        }
    }

    private fun loadDSBan() {
        viewModel.layDSBanTheoPhong().observe(viewLifecycleOwner) { dsBan ->
            dsBan.let {
                adapterT?.submitList(dsBan)
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
            val action =
                RoomReservationFragmentDirections.actionRoomReservationFragmentToTicketReservationFragment()
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
        val action =
            RoomReservationFragmentDirections.actionRoomReservationFragmentToLoginFragment()
        view?.findNavController()?.navigate(action)
    }
}