package com.example.API_RestaurantManagement.repository;

import com.example.API_RestaurantManagement.entity.KhachHangEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface KhachHangRepository extends JpaRepository<KhachHangEntity, Integer> {
}
