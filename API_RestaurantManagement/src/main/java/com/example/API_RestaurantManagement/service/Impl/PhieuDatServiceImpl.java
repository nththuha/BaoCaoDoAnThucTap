package com.example.API_RestaurantManagement.service.Impl;

import com.example.API_RestaurantManagement.dto.PhieuDatDTO;
import com.example.API_RestaurantManagement.entity.*;
import com.example.API_RestaurantManagement.repository.*;
import com.example.API_RestaurantManagement.service.PhieuDatService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class PhieuDatServiceImpl implements PhieuDatService {
    @Autowired
    private PhieuDatRepository phieuDatRepository;

    @Autowired
    private KhachHangRepository khachHangRepository;

    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Autowired
    private HoaDonRepository hoaDonRepository;

    @Autowired
    private CT_DatBanRepository ct_datBanRepository;

    @Autowired
    private CT_BanRepository ct_banRepository;

    @Override
    public List<PhieuDatDTO> layDSPhieuDatChuaCoHoaDon() {
        List<PhieuDatEntity> ds = phieuDatRepository.findAll();

        for (int i = 0; i < ds.size(); i++) {
            if (ds.get(i).getMahd() != null) {
                ds.remove(ds.get(i));
                i--;
            }
        }

        List<PhieuDatDTO> list = new ArrayList<>();

        for (int i = 0; i < ds.size(); i++) {
            CT_DatBanEntity ct_datBanEntity = ct_datBanRepository.findByIdpd_IdPD(ds.get(i).getIdPD());
            if (ct_datBanEntity.getIdctb() != null) {
                CT_BanEntity ct_banEntity = ct_banRepository.getById(ct_datBanEntity.getIdctb().getIdCTB());
                list.add(new PhieuDatDTO(ds.get(i)));
                list.get(i).setMaPhong(ct_banEntity.getMaphong().getMaPhong());
                list.get(i).setTenPhong(ct_banEntity.getMaphong().getTenPhong());
                list.get(i).setMaBan(ct_banEntity.getMaban().getMaBan());
                list.get(i).setTenBan(ct_banEntity.getMaban().getTenBan());
            }
        }
        return list;
    }

    @Override
    public PhieuDatDTO themPhieuDat(PhieuDatDTO phieuDatDTO) {
        List<CT_BanEntity> temp = ct_banRepository.findByMaphong_MaPhong(phieuDatDTO.getMaPhong());
        CT_BanEntity ct_banEntity = null;
        for (int i = 0; i < temp.size(); i++) {
            if (temp.get(i).getMaban().getMaBan().equals(phieuDatDTO.getMaBan())) {
                ct_banEntity = temp.get(i);
                ct_banEntity.setTrangThai("Unavailable");
                ct_banRepository.save(ct_banEntity);
                break;
            }
        }

        NhanVienEntity nhanVienEntity = nhanVienRepository.getById(phieuDatDTO.getIdnv());
//        if(phieuDatDTO.getIdkh() != null) KhachHangEntity khachHangEntity = khachHangRepository.getById(phieuDatDTO.getIdkh());
        PhieuDatEntity phieuDatEntity = phieuDatDTO.toEntity();
        phieuDatEntity.setIdnv(nhanVienEntity);
//        phieuDatEntity.setIdkh(khachHangEntity);
        PhieuDatEntity savePD = phieuDatRepository.save(phieuDatEntity);

        CT_DatBanEntity ct_datBanEntity = new CT_DatBanEntity();
        ct_datBanEntity.setIdctb(ct_banEntity);
        ct_datBanEntity.setIdpd(savePD);
        ct_datBanRepository.save(ct_datBanEntity);

        return new PhieuDatDTO(savePD);
    }

    @Override
    public PhieuDatDTO suaPhieuDat(PhieuDatDTO phieuDatDTO) {
        NhanVienEntity nhanVienEntity = nhanVienRepository.getById(phieuDatDTO.getIdnv());
        KhachHangEntity khachHangEntity = khachHangRepository.getById(phieuDatDTO.getIdkh());
        HoaDonEntity hoaDonEntity = null;
        if (phieuDatDTO.getMahd() != null) hoaDonEntity = hoaDonRepository.getById(phieuDatDTO.getMahd());
        PhieuDatEntity phieuDatEntity = phieuDatRepository.getById(phieuDatDTO.getIdPD());
        phieuDatEntity.setNgay(phieuDatDTO.getNgay());
        if (hoaDonEntity != null) phieuDatEntity.setMahd(hoaDonEntity);
        phieuDatEntity.setIdnv(nhanVienEntity);
        phieuDatEntity.setIdkh(khachHangEntity);
        PhieuDatEntity savePD = phieuDatRepository.save(phieuDatEntity);
        return new PhieuDatDTO(savePD);
    }
}
