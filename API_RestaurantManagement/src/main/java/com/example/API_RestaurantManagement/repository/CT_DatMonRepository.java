package com.example.API_RestaurantManagement.repository;

import com.example.API_RestaurantManagement.entity.CT_DatMonEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface CT_DatMonRepository extends JpaRepository<CT_DatMonEntity, Integer> {
    public List<CT_DatMonEntity> findByIdpd_IdPD(Integer idpd);
}
