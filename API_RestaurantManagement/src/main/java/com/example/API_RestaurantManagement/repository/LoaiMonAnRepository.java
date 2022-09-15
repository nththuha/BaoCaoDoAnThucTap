package com.example.API_RestaurantManagement.repository;

import com.example.API_RestaurantManagement.entity.LoaiMonAnEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface LoaiMonAnRepository extends JpaRepository<LoaiMonAnEntity, String> {
}
