package com.example.API_RestaurantManagement.service;

import com.example.API_RestaurantManagement.dto.BanDTO;

import java.util.List;

public interface BanService {
    List<BanDTO> layDSBan();

    BanDTO themBan(BanDTO banDTO);

    BanDTO suaBan(BanDTO banDTO);

    String xoaBan(String maBan);
}
