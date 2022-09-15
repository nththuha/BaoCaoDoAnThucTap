package com.example.ordermanagement.ui.detail

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import com.example.ordermanagement.databinding.FragmentHeaderBinding
import com.example.ordermanagement.viewmodel.BartenderViewModel
import com.example.ordermanagement.viewmodel.KitchenViewModel
import com.example.ordermanagement.viewmodel.RestaurantViewModel

class HeaderFragment : Fragment() {
    private val viewModel: RestaurantViewModel by activityViewModels()
    private val vm: KitchenViewModel by activityViewModels()
    private val v: BartenderViewModel by activityViewModels()

    private var _binding: FragmentHeaderBinding? = null
    private val binding get() = _binding!!

    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentHeaderBinding.inflate(inflater, container, false)
        var ten = if (viewModel.nhanVien.hoTen != "error") viewModel.nhanVien.hoTen
        else if (vm.nhanVien.hoTen != "error") vm.nhanVien.hoTen
        else v.nhanVien.hoTen
        binding.tvNhanVien.text = "Hi, $ten"
        return binding.root
    }
}