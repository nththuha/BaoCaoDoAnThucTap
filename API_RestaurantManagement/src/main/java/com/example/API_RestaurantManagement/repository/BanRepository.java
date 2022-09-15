package com.example.API_RestaurantManagement.repository;

import com.example.API_RestaurantManagement.entity.BanEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface BanRepository extends JpaRepository<BanEntity, String> {
}
