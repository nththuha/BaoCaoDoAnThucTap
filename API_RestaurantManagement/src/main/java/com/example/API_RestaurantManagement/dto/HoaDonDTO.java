package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.HoaDonEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class HoaDonDTO {
    private String maHD;

    private Date ngay;

    private int trigia;

    private int giaSauThue;

    private String masothue;

    private String hotenkh;

    private List<PhieuDatDTO> phieudatList;

    private Integer idnv;

    public HoaDonDTO(HoaDonEntity hoaDonEntity) {
        this.maHD = hoaDonEntity.getMaHD();
        this.ngay = hoaDonEntity.getNgay();
        this.trigia = hoaDonEntity.getTrigia();
        this.giaSauThue = hoaDonEntity.getGiaSauThue();
        if (hoaDonEntity.getMasothue() != null) this.masothue = hoaDonEntity.getMasothue();
        if (hoaDonEntity.getHotenkh() != null) this.hotenkh = hoaDonEntity.getHotenkh();
        if (hoaDonEntity.getPhieudatList() != null)
            this.phieudatList = hoaDonEntity.getPhieudatList().stream().map(PhieuDatDTO::new).collect(Collectors.toList());
        this.idnv = hoaDonEntity.getIdnv().getIdNV();
    }

    public HoaDonEntity toEntity() {
        HoaDonEntity hoaDonEntity = new HoaDonEntity();
        hoaDonEntity.setMaHD(this.maHD);
        hoaDonEntity.setNgay(this.ngay);
        hoaDonEntity.setTrigia(this.trigia);
        hoaDonEntity.setGiaSauThue(this.giaSauThue);
        if (this.masothue != null) hoaDonEntity.setMasothue(this.masothue);
        if (this.hotenkh != null) hoaDonEntity.setHotenkh(this.hotenkh);
        return hoaDonEntity;
    }
}
