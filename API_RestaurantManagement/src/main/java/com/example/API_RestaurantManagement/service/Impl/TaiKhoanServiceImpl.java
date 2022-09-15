package com.example.API_RestaurantManagement.service.Impl;

import com.example.API_RestaurantManagement.dto.NhanVienDTO;
import com.example.API_RestaurantManagement.dto.TaiKhoanDTO;
import com.example.API_RestaurantManagement.entity.NhanVienEntity;
import com.example.API_RestaurantManagement.entity.TaiKhoanEntity;
import com.example.API_RestaurantManagement.exception.NotFoundException;
import com.example.API_RestaurantManagement.repository.NhanVienRepository;
import com.example.API_RestaurantManagement.repository.TaiKhoanRepository;
import com.example.API_RestaurantManagement.service.TaiKhoanService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class TaiKhoanServiceImpl implements TaiKhoanService {
    @Autowired
    private TaiKhoanRepository taiKhoanRepository;

    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Override
    public NhanVienDTO kiemTraDangNhap(TaiKhoanDTO taiKhoanDTO) {
        TaiKhoanEntity tk = new TaiKhoanEntity();
        try {
            tk = taiKhoanRepository.findById(taiKhoanDTO.getMaTK()).orElseThrow(() -> new NotFoundException("Tài khoản " + taiKhoanDTO.getMaTK() + " không tồn tại!"));
        } catch (Exception e) {
            return null;
        }
        if (!taiKhoanDTO.getMatKhau().equals(tk.getMatKhau())) return null;
        NhanVienEntity temp = tk.getIdnv();
        NhanVienDTO nhanVienDTO = new NhanVienDTO(temp);
        return nhanVienDTO;
    }

    @Override
    public List<TaiKhoanDTO> layDSTaiKhoan() {
        List<TaiKhoanEntity> dsTK = taiKhoanRepository.findAll();
        return dsTK.stream().map(TaiKhoanDTO::new).collect(Collectors.toList());
    }

    @Override
    public TaiKhoanDTO themTaiKhoan(TaiKhoanDTO taiKhoanDTO) {
        NhanVienEntity nv = nhanVienRepository.getById(taiKhoanDTO.getIdnv());
        TaiKhoanEntity tk = taiKhoanDTO.toEntity();
        tk.setIdnv(nv);
        TaiKhoanEntity saveTK = taiKhoanRepository.save(tk);
        return new TaiKhoanDTO(saveTK);
    }

    @Override
    public TaiKhoanDTO layTaiKhoanTheoIDNV(Integer idnv) {
        TaiKhoanEntity tk = taiKhoanRepository.findByIdnv_IdNV(idnv);
        return new TaiKhoanDTO(tk);
    }

    @Override
    public TaiKhoanDTO suaTaiKhoan(TaiKhoanDTO taiKhoanDTO) {
        NhanVienEntity nv = nhanVienRepository.getById(taiKhoanDTO.getIdnv());
        TaiKhoanEntity tk = taiKhoanRepository.getById(taiKhoanDTO.getMaTK());
        tk.setMatKhau(taiKhoanDTO.getMatKhau());
        tk.setIdnv(nv);
        TaiKhoanEntity saveTK = taiKhoanRepository.save(tk);
        return new TaiKhoanDTO(saveTK);
    }
}
