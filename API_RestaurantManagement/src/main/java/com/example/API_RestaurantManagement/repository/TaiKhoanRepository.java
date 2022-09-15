package com.example.API_RestaurantManagement.repository;

import com.example.API_RestaurantManagement.entity.TaiKhoanEntity;
import org.springframework.data.jpa.repository.JpaRepository;

public interface TaiKhoanRepository extends JpaRepository<TaiKhoanEntity, String> {
    TaiKhoanEntity findByIdnv_IdNV(Integer idNV);
}
