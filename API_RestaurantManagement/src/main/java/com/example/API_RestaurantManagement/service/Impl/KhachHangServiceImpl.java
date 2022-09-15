package com.example.API_RestaurantManagement.service.Impl;

import com.example.API_RestaurantManagement.dto.KhachHangDTO;
import com.example.API_RestaurantManagement.entity.KhachHangEntity;
import com.example.API_RestaurantManagement.repository.KhachHangRepository;
import com.example.API_RestaurantManagement.service.KhachHangService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class KhachHangServiceImpl implements KhachHangService {
    @Autowired
    private KhachHangRepository khachHangRepository;

    @Override
    public List<KhachHangDTO> layDSKhachHang() {
        List<KhachHangEntity> ds = khachHangRepository.findAll();
        return ds.stream().map(KhachHangDTO::new).collect(Collectors.toList());
    }

    @Override
    public KhachHangDTO themKhachHang(KhachHangDTO khachHangDTO) {
        KhachHangEntity saveKhachHang = khachHangRepository.save(khachHangDTO.toEntity());
        return new KhachHangDTO(saveKhachHang);
    }
}
