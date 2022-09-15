package com.example.API_RestaurantManagement.service;

import com.example.API_RestaurantManagement.dto.PhieuDatDTO;

import java.util.List;

public interface PhieuDatService {
    List<PhieuDatDTO> layDSPhieuDatChuaCoHoaDon();

    PhieuDatDTO themPhieuDat(PhieuDatDTO phieuDatDTO);

    PhieuDatDTO suaPhieuDat(PhieuDatDTO phieuDatDTO);
}
