package com.example.API_RestaurantManagement.service;

import com.example.API_RestaurantManagement.dto.NhanVienDTO;

import java.util.List;

public interface NhanVienService {
    List<NhanVienDTO> layDSNhanVien();

    NhanVienDTO themNhanVien(NhanVienDTO nhanVienDTO);

    NhanVienDTO suaNhanVien(NhanVienDTO nhanVienDTO);

    String xoaNhanVien(Integer idNV);
}
