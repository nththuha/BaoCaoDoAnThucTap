package com.example.ordermanagement.model

import com.squareup.moshi.Json

data class CustomerEntity(
    @Json(name = "idKH") val idKH: Int,
    @Json(name = "hoTen") val hoTen: String,
    @Json(name = "sdt") val sdt: String
)
