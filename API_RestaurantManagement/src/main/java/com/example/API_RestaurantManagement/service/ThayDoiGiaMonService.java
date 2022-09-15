package com.example.API_RestaurantManagement.service;

import com.example.API_RestaurantManagement.dto.ThayDoiGiaMonDTO;

import java.util.List;

public interface ThayDoiGiaMonService {
    List<ThayDoiGiaMonDTO> layDSGiaMon(String maMA);

    ThayDoiGiaMonDTO themGiaMon(ThayDoiGiaMonDTO thayDoiGiaMonDTO);

    public int layGiaHienTai(String maMA);

    ThayDoiGiaMonDTO suaGiaMon(ThayDoiGiaMonDTO thayDoiGiaMonDTO);

    String xoaGiaMon(Integer idGM);
}
