package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.HoaDonEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.Date;
import java.util.List;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class HDDTO {
    private String maHD;

    private Date ngay;

    private int trigia;

    private int giaSauThue;

    private String giaChu;

    private String masothue;

    private String hotenkh;

    private List<CT_DatMonDTO> ctDatMonList;

    private Integer idnv;

    private String hoTenNV;

    public HDDTO(HoaDonEntity hoaDonEntity) {
        this.maHD = hoaDonEntity.getMaHD();
        this.ngay = hoaDonEntity.getNgay();
        this.trigia = hoaDonEntity.getTrigia();
        this.giaSauThue = hoaDonEntity.getGiaSauThue();
        if (hoaDonEntity.getMasothue() != null) this.masothue = hoaDonEntity.getMasothue();
        if (hoaDonEntity.getHotenkh() != null) this.hotenkh = hoaDonEntity.getHotenkh();
        this.idnv = hoaDonEntity.getIdnv().getIdNV();
        this.hoTenNV = hoaDonEntity.getIdnv().getHoTen();
    }
}
