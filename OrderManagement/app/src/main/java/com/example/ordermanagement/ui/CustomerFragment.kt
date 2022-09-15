package com.example.ordermanagement.ui

import android.os.Bundle
import android.view.*
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.ordermanagement.R
import com.example.ordermanagement.adapter.CustomerAdapter
import com.example.ordermanagement.databinding.FragmentCustomerBinding
import com.example.ordermanagement.viewmodel.RestaurantViewModel
import com.google.android.material.dialog.MaterialAlertDialogBuilder

class CustomerFragment : Fragment() {
    private val viewModel: RestaurantViewModel by activityViewModels()

    private var _binding: FragmentCustomerBinding? = null
    private val binding get() = _binding!!

    private var adapter: CustomerAdapter? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setHasOptionsMenu(true)
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentCustomerBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        adapter = CustomerAdapter {
            viewModel.chonKhachHang(it)
//            val action = CustomerFragmentDirections.actionCustomerFragmentToRoomReservationFragment()
//            view.findNavController().navigate(action)
        }
        loadDSKhachHang()

        binding.apply {
            rvCustomer.adapter = adapter

            val dividerItemDecoration = DividerItemDecoration(
                rvCustomer.context,
                LinearLayoutManager(requireContext()).orientation
            )
            rvCustomer.addItemDecoration(dividerItemDecoration)

            srCustomer.setOnRefreshListener {
                loadDSKhachHang()
                srCustomer.isRefreshing = false
            }

            ivAdd.setOnClickListener {

            }
        }
    }

    private fun loadDSKhachHang() {
        viewModel.layDSKhachHang().observe(viewLifecycleOwner) { dsKhachHang ->
            adapter?.submitList(dsKhachHang)
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
            showDialog("MESSAGE", "Do you want to log out?")
        }

        if (item.itemId == R.id.btnTrangChu) {
//            val action = CustomerFragmentDirections.actionCustomerFragmentToTicketReservationFragment()
//            view?.findNavController()?.navigate(action)
        }
        return super.onOptionsItemSelected(item)
    }

    private fun showDialog(tittle: String, message: String) {
        MaterialAlertDialogBuilder(requireContext())
            .setTitle(tittle)
            .setMessage(message)
            .setCancelable(false)
            .setPositiveButton("Yes") { _, _ -> goBack() }
            .setNegativeButton("No") { _, _ -> }
            .show()
    }

    private fun goBack() {
        viewModel.reset()
//        val action = CustomerFragmentDirections.actionCustomerFragmentToLoginFragment()
//        view?.findNavController()?.navigate(action)
    }
}