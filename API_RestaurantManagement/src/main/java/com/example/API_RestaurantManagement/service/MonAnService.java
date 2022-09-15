package com.example.API_RestaurantManagement.service;

import com.example.API_RestaurantManagement.dto.MonAnDTO;

import java.util.List;

public interface MonAnService {
    List<MonAnDTO> layDSMonAn();

    MonAnDTO themMonAn(MonAnDTO monAnDTO);

    MonAnDTO suaMonAn(MonAnDTO monAnDTO);

    String xoaMonAn(String maMA);

    MonAnDTO suaTrangThaiMonAn(String maMA);
}
