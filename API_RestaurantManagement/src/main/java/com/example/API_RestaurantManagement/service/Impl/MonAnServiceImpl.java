package com.example.API_RestaurantManagement.service.Impl;

import com.example.API_RestaurantManagement.dto.MonAnDTO;
import com.example.API_RestaurantManagement.entity.LoaiMonAnEntity;
import com.example.API_RestaurantManagement.entity.MonAnEntity;
import com.example.API_RestaurantManagement.repository.LoaiMonAnRepository;
import com.example.API_RestaurantManagement.repository.MonAnRepository;
import com.example.API_RestaurantManagement.service.MonAnService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class MonAnServiceImpl implements MonAnService {
    @Autowired
    private MonAnRepository monAnRepository;

    @Autowired
    private LoaiMonAnRepository loaiMonAnRepository;

    @Override
    public List<MonAnDTO> layDSMonAn() {
        List<MonAnEntity> dsMonAn = monAnRepository.findAll();
        return dsMonAn.stream().map(MonAnDTO::new).collect(Collectors.toList());
    }

    @Override
    public MonAnDTO themMonAn(MonAnDTO monAnDTO) {
        LoaiMonAnEntity loaiMonAnEntity = loaiMonAnRepository.getById(monAnDTO.getMalma());
        MonAnEntity monAnTemp = monAnDTO.toEntity();
        monAnTemp.setMalma(loaiMonAnEntity);
        MonAnEntity saveMonAnDTO = monAnRepository.save(monAnTemp);
        return new MonAnDTO(saveMonAnDTO);
    }

    @Override
    public MonAnDTO suaMonAn(MonAnDTO monAnDTO) {
        LoaiMonAnEntity loaiMonAnEntity = loaiMonAnRepository.getById(monAnDTO.getMalma());
        MonAnEntity monAnEntity = monAnRepository.getById(monAnDTO.getMaMA());
        monAnEntity.setTenMA(monAnDTO.getTenMA());
        monAnEntity.setChuThich(monAnDTO.getChuThich());
        monAnEntity.setHinhAnh(monAnDTO.getHinhAnh());
        monAnEntity.setTrangThai(monAnDTO.getTrangThai());
        monAnEntity.setMalma(loaiMonAnEntity);
        MonAnEntity saveMonAnDTO = monAnRepository.save(monAnEntity);
        return new MonAnDTO(saveMonAnDTO);
    }

    @Override
    public String xoaMonAn(String maMA) {
        try {
            monAnRepository.xoaMonAn(maMA);
            return "true";
        } catch (Exception e) {
            return "false";
        }
    }

    @Override
    public MonAnDTO suaTrangThaiMonAn(String maMA) {
        MonAnEntity ma = monAnRepository.getById(maMA);
        if (ma.getTrangThai().equals("In stock")) ma.setTrangThai("Out stock");
        else ma.setTrangThai("In stock");
        MonAnEntity saveMA = monAnRepository.save(ma);
        return new MonAnDTO(saveMA);
    }
}
