package com.example.ordermanagement.viewmodel

import android.util.Log
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.ordermanagement.model.FoodEntity
import com.example.ordermanagement.model.NhanVienEntity
import com.example.ordermanagement.model.OrderDetailEntity
import com.example.ordermanagement.network.RestaurantApi
import kotlinx.coroutines.launch

class KitchenViewModel : ViewModel() {
    lateinit var nhanVien: NhanVienEntity

    private val _dsCTDatMon = MutableLiveData<List<OrderDetailEntity>>()
    private val dsCTDatMon: LiveData<List<OrderDetailEntity>> = _dsCTDatMon

    private val _ctDatMon = MutableLiveData<OrderDetailEntity>()
    val ctDatMon: LiveData<OrderDetailEntity> = _ctDatMon

    private val _monAn = MutableLiveData<FoodEntity>()
    val monAn: LiveData<FoodEntity> = _monAn

    init {
        reset()
    }

    fun layDSDatMon_MonAn(): LiveData<List<OrderDetailEntity>> {
        viewModelScope.launch {
            try {
                _dsCTDatMon.value = RestaurantApi.retrofitService.layDSDatMon_MonAn()
            } catch (e: Exception) {
                Log.e("Lỗi load ds CTDM", e.message.toString())
            }
        }
        return dsCTDatMon
    }

    fun suaCT_DatMon(ctdatmon: OrderDetailEntity): MutableLiveData<OrderDetailEntity> {
        viewModelScope.launch {
            try {
                _ctDatMon.value = RestaurantApi.retrofitService.suaCTDatMon(ctdatmon)
            } catch (e: Exception) {
                Log.e("Lỗi sửa ct đặt món", e.message.toString())
            }
        }
        return _ctDatMon
    }

    fun xoaCT_DatMon(idCTDM: Int): Boolean {
        var s = true
        viewModelScope.launch {
            try {
                s = RestaurantApi.retrofitService.xoaCTDatMon(idCTDM)
            } catch (e: Exception) {
                Log.e("Lỗi xóa CT Đặt món", e.message.toString())
            }
        }
        return s
    }

    fun suaMonAn(monAn: FoodEntity): FoodEntity {
        viewModelScope.launch {
            try {
                _monAn.value = RestaurantApi.retrofitService.suaMonAn(monAn)
            } catch (e: Exception) {
                Log.e("Lỗi sửa món ăn", e.message.toString())
            }
        }
        return monAn
    }

    fun suaTrangThaiMonAn(maMA: String): LiveData<FoodEntity> {
        viewModelScope.launch {
            try {
                _monAn.value = RestaurantApi.retrofitService.suaTrangThaiMonAn(maMA)
            } catch (e: Exception) {
                Log.e("Lỗi sửa tt món ăn", e.message.toString())
            }
        }
        return monAn
    }

    fun themNhanVien(nhanVien: NhanVienEntity) {
        this.nhanVien = nhanVien
    }

    fun reset() {
        nhanVien = NhanVienEntity(1, "error", "error", "error", "error", "error", "error", "error")
    }
}