package com.example.API_RestaurantManagement.repository;

import com.example.API_RestaurantManagement.entity.MonAnEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import javax.transaction.Transactional;
import java.util.List;

@Repository
public interface MonAnRepository extends JpaRepository<MonAnEntity, String> {
    @Transactional
    @Modifying
    @Query(value = "delete from monan where mama=:maMA", nativeQuery = true)
    public void xoaMonAn(@Param("maMA") String maMA);

    List<MonAnEntity> findByMalma_MaLMA(String maLMA);
}
