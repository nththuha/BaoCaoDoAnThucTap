package com.example.API_RestaurantManagement.service;

import com.example.API_RestaurantManagement.dto.LoaiMonAnDTO;
import com.example.API_RestaurantManagement.dto.MonAnDTO;

import java.util.List;

public interface LoaiMonAnService {
    public List<LoaiMonAnDTO> layDSLoaiMonAn();

    LoaiMonAnDTO themLoaiMonAn(LoaiMonAnDTO loaiMonAnDTO);

    LoaiMonAnDTO suaLoaiMonAn(LoaiMonAnDTO loaiMonAnDTO);

    boolean xoaLoaiMonAn(String maLMA);

    List<MonAnDTO> layDSMonAnTheoLoaiMonAn(String maLMA);
}
