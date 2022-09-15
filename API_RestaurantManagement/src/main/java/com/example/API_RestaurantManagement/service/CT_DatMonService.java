package com.example.API_RestaurantManagement.service;

import com.example.API_RestaurantManagement.dto.CT_DatMonDTO;

import java.util.List;

public interface CT_DatMonService {
    List<CT_DatMonDTO> layDSCT_DatMonTheoPhieuDat(Integer idpd);

    CT_DatMonDTO themCT_DatMon(CT_DatMonDTO ct_datMonDTO);

    String xoaCT_DatMon(Integer idpd);

    CT_DatMonDTO suaCT_DatMon(CT_DatMonDTO ct_datMonDTO);

    List<CT_DatMonDTO> layDSCT_DatMon_MonAn();

    List<CT_DatMonDTO> layDSCT_DatMon_NuocUong();
}
