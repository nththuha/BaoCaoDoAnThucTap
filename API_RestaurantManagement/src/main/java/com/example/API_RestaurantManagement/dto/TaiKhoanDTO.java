package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.TaiKhoanEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class TaiKhoanDTO {
    private String maTK;

    private String matKhau;

    private int idnv;

    private String hoTenNV;

    public TaiKhoanDTO(TaiKhoanEntity taiKhoanEntity) {
        this.maTK = taiKhoanEntity.getMaTK();
        this.matKhau = taiKhoanEntity.getMatKhau();
        this.idnv = taiKhoanEntity.getIdnv().getIdNV();
        this.hoTenNV = taiKhoanEntity.getIdnv().getHoTen();
    }

    public TaiKhoanEntity toEntity() {
        TaiKhoanEntity taiKhoanEntity = new TaiKhoanEntity();
        taiKhoanEntity.setMaTK(this.maTK);
        taiKhoanEntity.setMatKhau(this.matKhau);
        return taiKhoanEntity;
    }
}
