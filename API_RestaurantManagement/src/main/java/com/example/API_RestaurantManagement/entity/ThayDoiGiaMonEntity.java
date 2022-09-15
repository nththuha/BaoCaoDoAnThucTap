package com.example.API_RestaurantManagement.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.*;
import java.util.Date;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "THAYDOIGIAMON")
public class ThayDoiGiaMonEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDGM")
    private Integer idGM;

    @Column(name = "GIA")
    private Integer gia;

    @Column(name = "NGAY")
    @Temporal(TemporalType.DATE)
    @DateTimeFormat(pattern = "dd/MM/yyyy")
    private Date ngay;

    @ManyToOne
    @JoinColumn(name = "MAMA")
    private MonAnEntity mama;

    @ManyToOne
    @JoinColumn(name = "IDNV")
    private NhanVienEntity idnv;
}
