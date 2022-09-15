package com.example.API_RestaurantManagement.service;

import com.example.API_RestaurantManagement.dto.KhachHangDTO;

import java.util.List;

public interface KhachHangService {
    List<KhachHangDTO> layDSKhachHang();

    KhachHangDTO themKhachHang(KhachHangDTO khachHangDTO);
}
