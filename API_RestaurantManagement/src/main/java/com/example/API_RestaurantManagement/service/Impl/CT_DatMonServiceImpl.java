package com.example.API_RestaurantManagement.service.Impl;

import com.example.API_RestaurantManagement.dto.CT_DatMonDTO;
import com.example.API_RestaurantManagement.entity.*;
import com.example.API_RestaurantManagement.repository.*;
import com.example.API_RestaurantManagement.service.CT_DatMonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class CT_DatMonServiceImpl implements CT_DatMonService {
    @Autowired
    private CT_DatMonRepository ct_datMonRepository;

    @Autowired
    private MonAnRepository monAnRepository;

    @Autowired
    private PhieuDatRepository phieuDatRepository;

    @Autowired
    private CT_DatBanRepository ct_datBanRepository;

    @Autowired
    private CT_BanRepository ct_banRepository;

    @Override
    public List<CT_DatMonDTO> layDSCT_DatMonTheoPhieuDat(Integer idpd) {
        List<CT_DatMonEntity> ds = ct_datMonRepository.findByIdpd_IdPD(idpd);
        for (int i = 0; i < ds.size(); i++) {
            for (int j = i; j < ds.size(); j++) {
                if (ds.get(i).getIdCTDM() > ds.get(j).getIdCTDM()) {
                    CT_DatMonEntity temp = ds.get(i);
                    ds.set(i, ds.get(j));
                    ds.set(j, temp);
                }
            }
        }
        return ds.stream().map(CT_DatMonDTO::new).collect(Collectors.toList());
    }

    @Override
    public CT_DatMonDTO themCT_DatMon(CT_DatMonDTO ct_datMonDTO) {
        MonAnEntity monAnEntity = monAnRepository.getById(ct_datMonDTO.getMama());
        PhieuDatEntity phieuDatEntity = phieuDatRepository.getById(ct_datMonDTO.getIdpd());
        CT_DatMonEntity ct_datMonEntity = new CT_DatMonEntity();
        ct_datMonEntity.setChuThich(ct_datMonDTO.getChuThich());
        ct_datMonEntity.setSoLuong(ct_datMonDTO.getSoLuong());
        ct_datMonEntity.setTrangThai(ct_datMonDTO.getTrangThai());
        ct_datMonEntity.setGia(ct_datMonDTO.getGia());
        ct_datMonEntity.setMama(monAnEntity);
        ct_datMonEntity.setIdpd(phieuDatEntity);
        CT_DatMonEntity saveCT = ct_datMonRepository.save(ct_datMonEntity);
        return new CT_DatMonDTO(saveCT);
    }

    @Override
    public String xoaCT_DatMon(Integer idpd) {
        CT_DatMonEntity temp = ct_datMonRepository.getById(idpd);
        try {
            ct_datMonRepository.deleteById(idpd);
            return "true";
        } catch (Exception e) {
            return "false";
        }

    }

    @Override
    public CT_DatMonDTO suaCT_DatMon(CT_DatMonDTO ct_datMonDTO) {
        MonAnEntity monAnEntity = monAnRepository.getById(ct_datMonDTO.getMama());
        PhieuDatEntity phieuDatEntity = phieuDatRepository.getById(ct_datMonDTO.getIdpd());
        CT_DatMonEntity ct_datMonEntity = ct_datMonRepository.getById(ct_datMonDTO.getIdCTDM());
        if (ct_datMonDTO.getChuThich() != null) ct_datMonEntity.setChuThich(ct_datMonDTO.getChuThich());
        ct_datMonEntity.setSoLuong(ct_datMonDTO.getSoLuong());
        ct_datMonEntity.setTrangThai(ct_datMonDTO.getTrangThai());
        ct_datMonEntity.setGia(ct_datMonDTO.getGia());
        ct_datMonEntity.setMama(monAnEntity);
        ct_datMonEntity.setIdpd(phieuDatEntity);
        CT_DatMonEntity saveCTDM = ct_datMonRepository.save(ct_datMonEntity);
        return new CT_DatMonDTO(saveCTDM);
    }

    @Override
    public List<CT_DatMonDTO> layDSCT_DatMon_MonAn() {
        List<CT_DatMonEntity> list = ct_datMonRepository.findAll();
        for (int i = 0; i < list.size(); i++) {
            if (list.get(i).getTrangThai().equals("done") || list.get(i).getMama().getMalma().getMaLMA().equals("LMA11") || list.get(i).getMama().getMalma().getMaLMA().equals("LMA10")) {
                list.remove(i);
                i--;
            }
        }

        for (int i = 0; i < list.size(); i++) {
            for (int j = i + 1; j < list.size(); j++) {
                if (list.get(i).getIdCTDM() > list.get(j).getIdCTDM()) {
                    CT_DatMonEntity temp = list.get(i);
                    list.set(i, list.get(j));
                    list.set(j, temp);
                }
            }
        }
        List<CT_DatMonDTO> m = list.stream().map(CT_DatMonDTO::new).collect(Collectors.toList());
        for (int i = 0; i < m.size(); i++) {
            CT_DatBanEntity ct_datBanEntity = ct_datBanRepository.findByIdpd_IdPD(m.get(i).getIdpd());
            if (ct_datBanEntity.getIdctb() != null) {
                CT_BanEntity ct_banEntity = ct_banRepository.getById(ct_datBanEntity.getIdctb().getIdCTB());
                m.get(i).setTenPhong(ct_banEntity.getMaphong().getTenPhong());
                m.get(i).setTenBan(ct_banEntity.getMaban().getTenBan());
            }
        }
        return m;
    }

    @Override
    public List<CT_DatMonDTO> layDSCT_DatMon_NuocUong() {
        List<CT_DatMonEntity> t = ct_datMonRepository.findAll();
        List<CT_DatMonEntity> list = new ArrayList<>();
        for (int i = 0; i < t.size(); i++) {
            if (!t.get(i).getTrangThai().equals("done") && t.get(i).getMama().getMalma().getMaLMA().equals("LMA11")) {
                list.add(t.get(i));
            } else if (!t.get(i).getTrangThai().equals("done") && t.get(i).getMama().getMalma().getMaLMA().equals("LMA10")) {
                list.add(t.get(i));
            }
        }

        for (int i = 0; i < list.size(); i++) {
            for (int j = i + 1; j < list.size(); j++) {
                if (list.get(i).getIdCTDM() > list.get(j).getIdCTDM()) {
                    CT_DatMonEntity temp = list.get(i);
                    list.set(i, list.get(j));
                    list.set(j, temp);
                }
            }
        }
        List<CT_DatMonDTO> m = list.stream().map(CT_DatMonDTO::new).collect(Collectors.toList());
        for (int i = 0; i < m.size(); i++) {
            CT_DatBanEntity ct_datBanEntity = ct_datBanRepository.findByIdpd_IdPD(m.get(i).getIdpd());
            if (ct_datBanEntity.getIdctb() != null) {
                CT_BanEntity ct_banEntity = ct_banRepository.getById(ct_datBanEntity.getIdctb().getIdCTB());
                m.get(i).setTenPhong(ct_banEntity.getMaphong().getTenPhong());
                m.get(i).setTenBan(ct_banEntity.getMaban().getTenBan());
            }
        }
        return m;
    }
}
