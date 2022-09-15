package com.example.API_RestaurantManagement.repository;

import com.example.API_RestaurantManagement.entity.PhieuDatEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface PhieuDatRepository extends JpaRepository<PhieuDatEntity, Integer> {
}
