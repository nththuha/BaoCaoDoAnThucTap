package com.example.API_RestaurantManagement.service.Impl;

import com.example.API_RestaurantManagement.dto.BanDTO;
import com.example.API_RestaurantManagement.dto.CT_BanDTO;
import com.example.API_RestaurantManagement.entity.BanEntity;
import com.example.API_RestaurantManagement.entity.CT_BanEntity;
import com.example.API_RestaurantManagement.entity.PhongEntity;
import com.example.API_RestaurantManagement.repository.BanRepository;
import com.example.API_RestaurantManagement.repository.CT_BanRepository;
import com.example.API_RestaurantManagement.repository.PhongRepository;
import com.example.API_RestaurantManagement.service.CT_BanService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class CT_BanServiceImpl implements CT_BanService {
    @Autowired
    private CT_BanRepository ct_banRepository;

    @Autowired
    private BanRepository banRepository;

    @Autowired
    private PhongRepository phongRepository;

    @Override
    public List<BanDTO> layDSBanTheoPhong(String maPhong) {
        List<CT_BanEntity> dsCT_Ban = ct_banRepository.findByMaphong_MaPhong(maPhong);
        List<BanDTO> dsBan = new ArrayList<>();
        for (int i = 0; i < dsCT_Ban.size(); i++) {
            for (int j = i; j < dsCT_Ban.size(); j++) {
                if (dsCT_Ban.get(i).getIdCTB() > dsCT_Ban.get(j).getIdCTB()) {
                    CT_BanEntity temp = dsCT_Ban.get(i);
                    dsCT_Ban.set(i, dsCT_Ban.get(j));
                    dsCT_Ban.set(j, temp);
                }
            }
        }
        for (CT_BanEntity item : dsCT_Ban) {
            BanDTO temp = new BanDTO(item.getMaban());
            temp.setTrangThai(item.getTrangThai());
            dsBan.add(temp);
        }

        return dsBan;
    }

    @Override
    public String themCTBan(CT_BanDTO ct_banDTO) {
        List<CT_BanEntity> list = ct_banRepository.findByMaphong_MaPhong(ct_banDTO.getMaphong());
        for (CT_BanEntity item : list) {
            if (item.getMaban().getMaBan().equals(ct_banDTO.getMaban())) {
                return "false";
            }
        }
        PhongEntity phong = phongRepository.getById(ct_banDTO.getMaphong());
        BanEntity ban = banRepository.getById(ct_banDTO.getMaban());
        CT_BanEntity ct_ban = ct_banDTO.toEntity();
        ct_ban.setMaphong(phong);
        ct_ban.setMaban(ban);
        ct_ban.setTrangThai("Available");
        CT_BanEntity saveCTBan = ct_banRepository.save(ct_ban);
        return "true";
    }

    @Override
    public String xoaCTBan(Integer idCTB) {
        try {
            ct_banRepository.deleteById(idCTB);
            return "true";
        } catch (Exception e) {
            return "false";
        }
    }

    @Override
    public List<CT_BanDTO> layDSCTBanTheoPhong(String maphong) {
        List<CT_BanEntity> list = ct_banRepository.findByMaphong_MaPhong(maphong);
        return list.stream().map(CT_BanDTO::new).collect(Collectors.toList());
    }
}
