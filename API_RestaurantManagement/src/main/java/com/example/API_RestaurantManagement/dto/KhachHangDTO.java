package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.KhachHangEntity;
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
public class KhachHangDTO {
    private Integer idKH;

    private String hoTen;

    private String sDT;

    private List<PhieuDatDTO> phieudatList;

    public KhachHangDTO(KhachHangEntity khachHangEntity) {
        this.idKH = khachHangEntity.getIdKH();
        this.hoTen = khachHangEntity.getHoTen();
        this.sDT = khachHangEntity.getSDT();
        this.phieudatList = khachHangEntity.getPhieudatList().stream().map(PhieuDatDTO::new).collect(Collectors.toList());
    }

    public KhachHangEntity toEntity() {
        KhachHangEntity khachHangEntity = new KhachHangEntity();
        khachHangEntity.setIdKH(this.idKH);
        khachHangEntity.setHoTen(this.hoTen);
        khachHangEntity.setSDT(this.sDT);
        return khachHangEntity;
    }
}
