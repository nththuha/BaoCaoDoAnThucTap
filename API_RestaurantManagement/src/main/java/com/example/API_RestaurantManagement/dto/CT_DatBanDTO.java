package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.CT_DatBanEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class CT_DatBanDTO {
    private Integer idCTDB;

    private Integer idctb;

    private Integer idpd;

    public CT_DatBanDTO(CT_DatBanEntity ct_datBanEntity) {
        this.idCTDB = ct_datBanEntity.getIdCTDB();
        this.idctb = ct_datBanEntity.getIdctb().getIdCTB();
        this.idpd = ct_datBanEntity.getIdpd().getIdPD();
    }

    public CT_DatBanEntity toEntity() {
        CT_DatBanEntity ct_banEntity = new CT_DatBanEntity();
        ct_banEntity.setIdCTDB(this.idCTDB);
        return ct_banEntity;
    }
}
