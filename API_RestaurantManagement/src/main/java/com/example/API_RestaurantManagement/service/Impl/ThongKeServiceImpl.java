package com.example.API_RestaurantManagement.service.Impl;

import com.example.API_RestaurantManagement.dto.TempDTO;
import com.example.API_RestaurantManagement.dto.ThongKeDTO;
import com.example.API_RestaurantManagement.repository.HoaDonRepository;
import com.example.API_RestaurantManagement.service.ThongKeService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;

@Service
public class ThongKeServiceImpl implements ThongKeService {
    @Autowired
    private HoaDonRepository hoaDonRepository;

    @Override
    public List<ThongKeDTO> thongKe(ThongKeDTO ngayDTO) {
        SimpleDateFormat thang = new SimpleDateFormat("MM");
        SimpleDateFormat nam = new SimpleDateFormat("yyyy");
        List<ThongKeDTO> list = new ArrayList<>();

        Calendar cal = Calendar.getInstance();
        cal.setTime(ngayDTO.getNgayBD());

        while (cal.getTime().getTime() <= ngayDTO.getNgayKT().getTime()) {
            ThongKeDTO thongKeDTO = new ThongKeDTO();
            thongKeDTO.setThang(thang.format(cal.getTime()));
            thongKeDTO.setNam(nam.format(cal.getTime()));
            thongKeDTO.setDoanhThu(0);
            list.add(thongKeDTO);
            cal.add(Calendar.MONTH, 1);
        }

        List<TempDTO> listTemp = hoaDonRepository.layThongKe(ngayDTO.getNgayBD(), ngayDTO.getNgayKT());
        List<ThongKeDTO> listT = new ArrayList<>();
        for (TempDTO temp : listTemp) {
            ThongKeDTO thongKeDTO = new ThongKeDTO();
            thongKeDTO.setThang(temp.getThang());
            thongKeDTO.setNam(temp.getNam());
            thongKeDTO.setDoanhThu(temp.getDoanhthu());
            listT.add(thongKeDTO);
        }

        for (int i = 0; i < list.size(); i++) {
            for (ThongKeDTO j : listT) {
                if (j.getThang().equals(list.get(i).getThang()) && j.getNam().equals(list.get(i).getNam())) {
                    list.get(i).setDoanhThu(j.getDoanhThu());
                }
            }
        }

        return list;
    }
}
