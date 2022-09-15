package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.CT_BanEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.List;
import java.util.stream.Collectors;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class CT_BanDTO {
    private Integer idCTB;

    private Integer soGhe;
    private String trangThai;
    private String maban;

    private String tenban;

    private String maphong;

    private String tenphong;

    private List<CT_DatBanDTO> ctDatBanList;

    public CT_BanDTO(CT_BanEntity ct_banEntity) {
        this.idCTB = ct_banEntity.getIdCTB();
        this.soGhe = ct_banEntity.getSoGhe();
        this.trangThai = ct_banEntity.getTrangThai();
        this.maban = ct_banEntity.getMaban().getMaBan();
        this.tenban = ct_banEntity.getMaban().getTenBan();
        this.maphong = ct_banEntity.getMaphong().getMaPhong();
        this.tenphong = ct_banEntity.getMaphong().getTenPhong();
        this.ctDatBanList = ct_banEntity.getCtDatBanList().stream().map(CT_DatBanDTO::new).collect(Collectors.toList());
    }

    public CT_BanEntity toEntity() {
        CT_BanEntity ct_banEntity = new CT_BanEntity();
        ct_banEntity.setIdCTB(this.idCTB);
        ct_banEntity.setTrangThai(this.trangThai);
        ct_banEntity.setSoGhe(this.soGhe);
        return ct_banEntity;
    }
}
