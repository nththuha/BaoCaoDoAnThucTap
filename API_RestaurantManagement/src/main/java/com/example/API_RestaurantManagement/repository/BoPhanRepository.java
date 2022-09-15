package com.example.API_RestaurantManagement.repository;

import com.example.API_RestaurantManagement.entity.BoPhanEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface BoPhanRepository extends JpaRepository<BoPhanEntity, String> {
}
