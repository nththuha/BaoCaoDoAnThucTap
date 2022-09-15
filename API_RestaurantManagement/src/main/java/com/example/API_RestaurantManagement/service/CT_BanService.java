package com.example.API_RestaurantManagement.service;

import com.example.API_RestaurantManagement.dto.BanDTO;
import com.example.API_RestaurantManagement.dto.CT_BanDTO;

import java.util.List;

public interface CT_BanService {
    List<BanDTO> layDSBanTheoPhong(String maPhong);

    String themCTBan(CT_BanDTO ct_banDTO);

    String xoaCTBan(Integer idCTB);

    List<CT_BanDTO> layDSCTBanTheoPhong(String maphong);
}
