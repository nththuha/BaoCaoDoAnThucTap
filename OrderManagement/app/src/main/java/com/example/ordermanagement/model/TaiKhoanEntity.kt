package com.example.ordermanagement.model

import com.squareup.moshi.Json

data class TaiKhoanEntity(
    @Json(name = "maTK") val maTK: String,
    @Json(name = "matKhau") val matKhau: String
)
