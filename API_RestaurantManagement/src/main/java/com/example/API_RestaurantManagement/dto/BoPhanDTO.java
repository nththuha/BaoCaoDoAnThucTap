package com.example.API_RestaurantManagement.dto;

import com.example.API_RestaurantManagement.entity.BoPhanEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.List;
import java.util.stream.Collectors;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class BoPhanDTO {
    private String maBP;

    private String tenBP;

    private List<NhanVienDTO> nhanVienList;

    public BoPhanDTO(BoPhanEntity boPhanEntity) {
        this.maBP = boPhanEntity.getMaBP();
        this.tenBP = boPhanEntity.getTenBP();
        this.nhanVienList = boPhanEntity.getNhanVienList().stream().map(NhanVienDTO::new).collect(Collectors.toList());
    }

    public BoPhanEntity toEntity() {
        BoPhanEntity boPhanEntity = new BoPhanEntity();
        boPhanEntity.setMaBP(this.maBP);
        boPhanEntity.setTenBP(this.tenBP);
        return boPhanEntity;
    }
}
