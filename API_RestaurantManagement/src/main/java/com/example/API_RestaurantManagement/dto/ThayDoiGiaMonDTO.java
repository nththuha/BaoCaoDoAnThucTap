package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.ThayDoiGiaMonEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.Date;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class ThayDoiGiaMonDTO {
    private Integer idGM;

    private Integer gia;

    private Date ngay;

    private String mama;

    private Integer idnv;

    private String hoTenNV;

    public ThayDoiGiaMonDTO(ThayDoiGiaMonEntity thayDoiGiaMonEntity) {
        this.idGM = thayDoiGiaMonEntity.getIdGM();
        this.gia = thayDoiGiaMonEntity.getGia();
        this.ngay = thayDoiGiaMonEntity.getNgay();
        this.mama = thayDoiGiaMonEntity.getMama().getMaMA();
        this.idnv = thayDoiGiaMonEntity.getIdnv().getIdNV();
        this.hoTenNV = thayDoiGiaMonEntity.getIdnv().getHoTen();
    }

    public ThayDoiGiaMonEntity toEntity() {
        ThayDoiGiaMonEntity thayDoiGiaMonEntity = new ThayDoiGiaMonEntity();
        thayDoiGiaMonEntity.setIdGM(this.idGM);
        thayDoiGiaMonEntity.setGia(this.gia);
        thayDoiGiaMonEntity.setNgay(this.ngay);
        return thayDoiGiaMonEntity;
    }
}
