package com.example.API_RestaurantManagement.service;

import com.example.API_RestaurantManagement.dto.ThongKeDTO;

import java.util.List;

public interface ThongKeService {
    List<ThongKeDTO> thongKe(ThongKeDTO thongKeDTO);
}
