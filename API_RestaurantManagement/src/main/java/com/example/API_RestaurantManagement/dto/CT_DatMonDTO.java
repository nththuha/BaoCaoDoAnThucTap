package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.CT_DatMonEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class CT_DatMonDTO {
    private Integer idCTDM;

    private int soLuong;

    private String chuThich;

    private String trangThai;

    private int gia;

    private int giaTungMon;

    private String mama;

    private String tenma;

    private String malma;

    private Integer idpd;

    private String tenPhong;
    private String tenBan;


    public CT_DatMonDTO(CT_DatMonEntity ct_datMonEntity) {
        this.idCTDM = ct_datMonEntity.getIdCTDM();
        this.soLuong = ct_datMonEntity.getSoLuong();
        this.chuThich = ct_datMonEntity.getChuThich();
        this.trangThai = ct_datMonEntity.getTrangThai();
        this.gia = ct_datMonEntity.getGia();
        this.mama = ct_datMonEntity.getMama().getMaMA();
        this.tenma = ct_datMonEntity.getMama().getTenMA();
        this.malma = ct_datMonEntity.getMama().getMalma().getMaLMA();
        this.idpd = ct_datMonEntity.getIdpd().getIdPD();
    }

    public CT_DatMonEntity toEntity() {
        CT_DatMonEntity ct_datMonEntity = new CT_DatMonEntity();
        ct_datMonEntity.setIdCTDM(this.idCTDM);
        ct_datMonEntity.setSoLuong(this.soLuong);
        ct_datMonEntity.setChuThich(this.chuThich);
        ct_datMonEntity.setGia(this.gia);
        return ct_datMonEntity;
    }
}
