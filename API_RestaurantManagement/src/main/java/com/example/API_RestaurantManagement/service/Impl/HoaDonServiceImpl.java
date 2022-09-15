package com.example.API_RestaurantManagement.service.Impl;

import com.example.API_RestaurantManagement.dto.CT_DatMonDTO;
import com.example.API_RestaurantManagement.dto.HDDTO;
import com.example.API_RestaurantManagement.dto.HoaDonDTO;
import com.example.API_RestaurantManagement.dto.PhieuDatDTO;
import com.example.API_RestaurantManagement.entity.*;
import com.example.API_RestaurantManagement.repository.*;
import com.example.API_RestaurantManagement.service.HoaDonService;
import com.example.API_RestaurantManagement.service.ThayDoiGiaMonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class HoaDonServiceImpl implements HoaDonService {
    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Autowired
    private HoaDonRepository hoaDonRepository;

    @Autowired
    private PhieuDatRepository phieuDatRepository;

    @Autowired
    private KhachHangRepository khachHangRepository;

    @Autowired
    private CT_DatMonRepository ct_datMonRepository;

    @Autowired
    private CT_BanRepository ct_banRepository;

    @Autowired
    private CT_DatBanRepository ct_datBanRepository;

    @Autowired
    private ThayDoiGiaMonService thayDoiGiaMonService;

    public HoaDonServiceImpl() {
    }

    @Override
    public HDDTO themHoaDon(HoaDonDTO hoaDonDTO) {
        NhanVienEntity nhanVien = nhanVienRepository.getById(hoaDonDTO.getIdnv());
        HoaDonEntity hoaDon = hoaDonDTO.toEntity();
        hoaDon.setIdnv(nhanVien);
        HoaDonEntity saveHD = hoaDonRepository.save(hoaDon); //hóa đơn mới vừa thêm

        List<CT_DatMonDTO> dsCTDM = new ArrayList<>();

        List<PhieuDatDTO> dsPD = hoaDonDTO.getPhieudatList();
        for (int i = 0; i < dsPD.size(); i++) {
            PhieuDatDTO phieuDatDTO = dsPD.get(i);
            PhieuDatEntity pd = phieuDatDTO.toEntity();
            NhanVienEntity nv = nhanVienRepository.getById(phieuDatDTO.getIdnv());
            KhachHangEntity kh = null;
            if (phieuDatDTO.getIdkh() != null) kh = khachHangRepository.getById(phieuDatDTO.getIdkh());
            pd.setMahd(saveHD);
            pd.setIdkh(kh);
            pd.setIdnv(nv);
            PhieuDatEntity savePD = phieuDatRepository.save(pd);

            List<CT_DatMonEntity> temp = ct_datMonRepository.findByIdpd_IdPD(savePD.getIdPD());
            dsCTDM.addAll(temp.stream().map(CT_DatMonDTO::new).collect(Collectors.toList()));

            CT_DatBanEntity ctDB = ct_datBanRepository.findByIdpd_IdPD(pd.getIdPD());
            CT_BanEntity ctBan = ct_banRepository.getById(ctDB.getIdctb().getIdCTB());
            ctBan.setTrangThai("Available");
            ct_banRepository.save(ctBan);
        }

        for (int i = 0; i < dsCTDM.size(); i++) {
            dsCTDM.get(i).setGiaTungMon(thayDoiGiaMonService.layGiaHienTai(dsCTDM.get(i).getMama()));
        }

        HDDTO hd = new HDDTO(saveHD);
        String tien = chuyenSangChu(String.valueOf(hd.getGiaSauThue()));
        String money = tien.substring(0, 1).toUpperCase() + tien.substring(1);

        hd.setGiaChu(money);
        hd.setCtDatMonList(dsCTDM);

        return hd;
    }

    public static HashMap<String, String> hm_tien = new HashMap<String, String>() {
        {
            put("0", "không");
            put("1", "một");
            put("2", "hai");
            put("3", "ba");
            put("4", "bốn");
            put("5", "năm");
            put("6", "sáu");
            put("7", "bảy");
            put("8", "tám");
            put("9", "chín");
        }
    };
    public static HashMap<String, String> hm_hanh = new HashMap<String, String>() {
        {
            put("1", "đồng");
            put("2", "mươi");
            put("3", "trăm");
            put("4", "nghìn");
            put("5", "mươi");
            put("6", "trăm");
            put("7", "triệu");
            put("8", "mươi");
            put("9", "trăm");
            put("10", "tỷ");
            put("11", "mươi");
            put("12", "trăm");
            put("13", "nghìn");
            put("14", "mươi");
            put("15", "trăm");
        }
    };

    public static String chuyenSangChu(String x) {
        StringBuilder kq = new StringBuilder();
        String m = x;
        int dem = m.length();
        String dau = "";
        int flag10 = 1;
        while (!m.equals("")) {
            if (m.length() <= 3 && m.length() > 1 && Long.parseLong(m) == 0) {
            } else {
                dau = m.substring(0, 1);
                if (dem % 3 == 1 && m.startsWith("1") && flag10 == 0) {
                    kq.append("mốt ");
                } else if (dem % 3 == 1 && m.startsWith("5") && flag10 == 0) {
                    kq.append("lăm ");
                } else if (dem % 3 == 2 && m.startsWith("1")) {
                    kq.append("mười ");
                    flag10 = 1;
                } else if (dem % 3 == 2 && m.startsWith("0") && m.charAt(1) != '0') {
                    kq.append("lẻ ");
                    flag10 = 1;
                } else {
                    if (!m.startsWith("0")) {
                        kq.append(hm_tien.get(dau)).append(" ");
                        flag10 = 0;
                    }
                }
                if (dem % 3 != 1 && m.startsWith("0")) {
                    //lẻ -> do nothing
                } else {
                    if (dem % 3 == 2 && (m.startsWith("1") || m.startsWith("0"))) {
                        //mười -> do nothing
                    } else {
                        kq.append(hm_hanh.get(dem + "")).append(" ");
                    }
                }
            }
            m = m.substring(1);
            dem = m.length();
        }
        kq = new StringBuilder(kq.substring(0, kq.length() - 1));
        return kq.toString();
    }
}
