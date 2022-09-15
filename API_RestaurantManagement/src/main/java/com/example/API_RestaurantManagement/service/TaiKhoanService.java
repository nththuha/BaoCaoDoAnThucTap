package com.example.API_RestaurantManagement.service;

import com.example.API_RestaurantManagement.dto.NhanVienDTO;
import com.example.API_RestaurantManagement.dto.TaiKhoanDTO;

import java.util.List;

public interface TaiKhoanService {
    public NhanVienDTO kiemTraDangNhap(TaiKhoanDTO taiKhoanDTO);

    List<TaiKhoanDTO> layDSTaiKhoan();

    TaiKhoanDTO themTaiKhoan(TaiKhoanDTO taiKhoanDTO);

    TaiKhoanDTO layTaiKhoanTheoIDNV(Integer idnv);

    TaiKhoanDTO suaTaiKhoan(TaiKhoanDTO taiKhoanDTO);
}
