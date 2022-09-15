package com.example.API_RestaurantManagement.service.Impl;

import com.example.API_RestaurantManagement.dto.LoaiMonAnDTO;
import com.example.API_RestaurantManagement.dto.MonAnDTO;
import com.example.API_RestaurantManagement.entity.LoaiMonAnEntity;
import com.example.API_RestaurantManagement.entity.MonAnEntity;
import com.example.API_RestaurantManagement.repository.LoaiMonAnRepository;
import com.example.API_RestaurantManagement.repository.MonAnRepository;
import com.example.API_RestaurantManagement.service.LoaiMonAnService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class LoaiMonAnServiceImpl implements LoaiMonAnService {
    @Autowired
    private LoaiMonAnRepository loaiMonAnRepository;

    @Autowired
    private MonAnRepository monAnRepository;

    @Override
    public List<LoaiMonAnDTO> layDSLoaiMonAn() {
        List<LoaiMonAnEntity> dsLoaiMonAn = loaiMonAnRepository.findAll();
        return dsLoaiMonAn.stream().map(LoaiMonAnDTO::new).collect(Collectors.toList());
    }

    @Override
    public LoaiMonAnDTO themLoaiMonAn(LoaiMonAnDTO loaiMonAnDTO) {
        LoaiMonAnEntity saveLoaiMonAnOTD = loaiMonAnRepository.save(loaiMonAnDTO.toEntity());
        return new LoaiMonAnDTO(saveLoaiMonAnOTD);
    }

    @Override
    public LoaiMonAnDTO suaLoaiMonAn(LoaiMonAnDTO loaiMonAnDTO) {
        LoaiMonAnEntity loaiMonAnEntity = loaiMonAnRepository.getById(loaiMonAnDTO.getMaLMA());
        loaiMonAnEntity.setTenLMA(loaiMonAnDTO.getTenLMA());
        loaiMonAnEntity.setHinhAnh(loaiMonAnDTO.getHinhAnh());
        LoaiMonAnEntity saveLoaiMonAnDTO = loaiMonAnRepository.save(loaiMonAnEntity);
        return new LoaiMonAnDTO(saveLoaiMonAnDTO);
    }

    @Override
    public boolean xoaLoaiMonAn(String maLMA) {
        try {
            loaiMonAnRepository.deleteById(maLMA);
            return true;
        } catch (Exception e) {
            return false;
        }
    }

    @Override
    public List<MonAnDTO> layDSMonAnTheoLoaiMonAn(String maLMA) {
        List<MonAnEntity> monAnEntity = monAnRepository.findByMalma_MaLMA(maLMA);
        return monAnEntity.stream().map(MonAnDTO::new).collect(Collectors.toList());
    }
}
