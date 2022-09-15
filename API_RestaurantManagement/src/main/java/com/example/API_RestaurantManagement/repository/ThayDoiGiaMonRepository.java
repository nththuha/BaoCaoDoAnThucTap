package com.example.API_RestaurantManagement.repository;

import com.example.API_RestaurantManagement.entity.ThayDoiGiaMonEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface ThayDoiGiaMonRepository extends JpaRepository<ThayDoiGiaMonEntity, Integer> {

    List<ThayDoiGiaMonEntity> findByMama_MaMAOrderByNgayDesc(String maMA);
}
