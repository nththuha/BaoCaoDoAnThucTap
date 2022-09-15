package com.example.API_RestaurantManagement.service.Impl;

import com.example.API_RestaurantManagement.dto.BanDTO;
import com.example.API_RestaurantManagement.entity.BanEntity;
import com.example.API_RestaurantManagement.entity.CT_BanEntity;
import com.example.API_RestaurantManagement.repository.BanRepository;
import com.example.API_RestaurantManagement.repository.CT_BanRepository;
import com.example.API_RestaurantManagement.service.BanService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Objects;
import java.util.stream.Collectors;

@Service
public class BanServiceImpl implements BanService {
    @Autowired
    private BanRepository banRepository;

    @Autowired
    private CT_BanRepository ct_banRepository;

    @Override
    public List<BanDTO> layDSBan() {
        List<BanEntity> list = banRepository.findAll();
        return list.stream().map(BanDTO::new).collect(Collectors.toList());
    }

    @Override
    public BanDTO themBan(BanDTO banDTO) {
        BanEntity ban = banDTO.toEntity();
        BanEntity saveBan = banRepository.save(ban);
        return new BanDTO(saveBan);
    }

    @Override
    public BanDTO suaBan(BanDTO banDTO) {
        BanEntity ban = banRepository.getById(banDTO.getMaBan());

        if (!Objects.equals(banDTO.getSoGhe(), ban.getSoGhe())) {
            List<CT_BanEntity> list = ct_banRepository.findByMaban_MaBan(banDTO.getMaBan());
            for (CT_BanEntity item : list) {
                item.setSoGhe(banDTO.getSoGhe());
            }
            ct_banRepository.saveAll(list);
        }

        ban.setTenBan(banDTO.getTenBan());
        ban.setSoGhe(banDTO.getSoGhe());
        BanEntity saveBan = banRepository.save(ban);
        return new BanDTO(saveBan);
    }

    @Override
    public String xoaBan(String maBan) {
        try {
            banRepository.deleteById(maBan);
            return "true";
        } catch (Exception e) {
            return "false";
        }
    }
}
