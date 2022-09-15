package com.example.API_RestaurantManagement.repository;

import com.example.API_RestaurantManagement.entity.CT_BanEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface CT_BanRepository extends JpaRepository<CT_BanEntity, Integer> {
    List<CT_BanEntity> findByMaphong_MaPhong(String maPhong);

    List<CT_BanEntity> findByMaban_MaBan(String maBan);
}
