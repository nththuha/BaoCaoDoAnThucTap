package com.example.ordermanagement.model

import com.squareup.moshi.Json

data class NhanVienEntity(
    @Json(name = "idNV") val idNV: Int,
    @Json(name = "hoTen") val hoTen: String,
    @Json(name = "diaChi") val diaChi: String,
    @Json(name = "email") val email: String,
    @Json(name = "taiKhoan") val taiKhoan: String,
    @Json(name = "maBP") val maBP: String,
    @Json(name = "tenBP") val tenBP: String,
    @Json(name = "sdt") val sdt: String
)
