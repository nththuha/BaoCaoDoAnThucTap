package com.example.ordermanagement.ui

import android.app.Dialog
import android.graphics.Color
import android.graphics.drawable.ColorDrawable
import android.os.Bundle
import android.view.*
import android.widget.Button
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import com.example.ordermanagement.R
import com.example.ordermanagement.adapter.TicketReservationAdapter
import com.example.ordermanagement.databinding.FragmentTicketReservationBinding
import com.example.ordermanagement.viewmodel.RestaurantViewModel

class TicketReservationFragment : Fragment() {
    private val viewModel: RestaurantViewModel by activityViewModels()

    private var _binding: FragmentTicketReservationBinding? = null
    private val binding get() = _binding!!

    private var adapter: TicketReservationAdapter? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setHasOptionsMenu(true)
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentTicketReservationBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        adapter = TicketReservationAdapter {
            viewModel.chonPhieuDat(it)
        }
        loadDSPhieuDatKhongHoaDon()
        binding.apply {
            rvTicket.adapter = adapter

            ivAdd.setOnClickListener {
                val action =
                    TicketReservationFragmentDirections.actionTicketReservationFragmentToRoomReservationFragment()
                view.findNavController().navigate(action)
            }

            srTicket.setOnRefreshListener {
                loadDSPhieuDatKhongHoaDon()
                srTicket.isRefreshing = false
            }
        }
    }

    private fun loadDSPhieuDatKhongHoaDon() {
        viewModel.layDSPhieuDatChuaCoHoaDon().observe(viewLifecycleOwner) { dsPhieuDat ->
            dsPhieuDat.let {
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
            TicketReservationFragmentDirections.actionTicketReservationFragmentToLoginFragment()
        view?.findNavController()?.navigate(action)
    }
}