package com.example.API_RestaurantManagement.repository;

import com.example.API_RestaurantManagement.entity.PhongEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface PhongRepository extends JpaRepository<PhongEntity, String> {
}
