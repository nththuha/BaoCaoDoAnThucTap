package com.example.API_RestaurantManagement.service;

import com.example.API_RestaurantManagement.dto.PhongDTO;

import java.util.List;

public interface PhongService {
    List<PhongDTO> layDSPhong();

    PhongDTO themPhong(PhongDTO phongDTO);

    PhongDTO suaPhong(PhongDTO phongDTO);

    String xoaPhong(String maPhong);
}
