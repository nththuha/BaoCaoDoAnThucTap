package com.example.API_RestaurantManagement.service.Impl;

import com.example.API_RestaurantManagement.dto.PhongDTO;
import com.example.API_RestaurantManagement.entity.CT_BanEntity;
import com.example.API_RestaurantManagement.entity.PhongEntity;
import com.example.API_RestaurantManagement.repository.CT_BanRepository;
import com.example.API_RestaurantManagement.repository.PhongRepository;
import com.example.API_RestaurantManagement.service.PhongService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class PhongServiceImpl implements PhongService {
    @Autowired
    private PhongRepository phongRepository;

    @Autowired
    private CT_BanRepository ct_banRepository;

    @Override
    public List<PhongDTO> layDSPhong() {
        List<PhongEntity> dsPhong = phongRepository.findAll();

        List<PhongDTO> ds = dsPhong.stream().map(PhongDTO::new).collect(Collectors.toList());
        for (int i = 0; i < ds.size(); i++) {
            String trangThai = "Unavailable";
            List<CT_BanEntity> dsCT_Ban = ct_banRepository.findByMaphong_MaPhong(ds.get(i).getMaPhong());
            for (int j = 0; j < dsCT_Ban.size(); j++) {
                if (dsCT_Ban.get(j).getTrangThai().equals("Available")) {
                    trangThai = "Available";
                    break;
                }
            }
            ds.get(i).setTrangThai(trangThai);
        }

        return ds;
    }

    @Override
    public PhongDTO themPhong(PhongDTO phongDTO) {
        PhongEntity phong = phongDTO.toEntity();
        PhongEntity savePhong = phongRepository.save(phong);
        return new PhongDTO(savePhong);
    }

    @Override
    public PhongDTO suaPhong(PhongDTO phongDTO) {
        PhongEntity phong = phongRepository.getById(phongDTO.getMaPhong());
        phong.setTenPhong(phongDTO.getTenPhong());
        PhongEntity savePhong = phongRepository.save(phong);
        return new PhongDTO(savePhong);
    }

    @Override
    public String xoaPhong(String maPhong) {
        try {
            phongRepository.deleteById(maPhong);
            return "true";
        } catch (Exception e) {
            return "false";
        }
    }
}
