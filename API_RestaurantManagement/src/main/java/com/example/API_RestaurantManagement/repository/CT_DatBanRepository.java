package com.example.API_RestaurantManagement.repository;

import com.example.API_RestaurantManagement.entity.CT_BanEntity;
import com.example.API_RestaurantManagement.entity.CT_DatBanEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface CT_DatBanRepository extends JpaRepository<CT_DatBanEntity, Integer> {
    public CT_DatBanEntity findByIdpd_IdPD(Integer idPD);

    public List<CT_BanEntity> findByIdctb_IdCTB(Integer idCTB);
}
