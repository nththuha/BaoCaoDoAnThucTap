package com.example.ordermanagement.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.ordermanagement.databinding.ItemCustomerBinding
import com.example.ordermanagement.model.CustomerEntity

class CustomerAdapter(private val clickListener: (CustomerEntity) -> Unit) :
    ListAdapter<CustomerEntity, CustomerAdapter.CustomerEntityViewHolder>(DiffCallback) {
    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): CustomerAdapter.CustomerEntityViewHolder {
        val viewHolder = CustomerEntityViewHolder(
            ItemCustomerBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
        viewHolder.itemView.setOnClickListener {
            val position = viewHolder.adapterPosition
            clickListener(getItem(position))
        }
        return viewHolder
    }

    override fun onBindViewHolder(holder: CustomerAdapter.CustomerEntityViewHolder, position: Int) {
        val customer = getItem(position)
        holder.bind(customer)
    }

    class CustomerEntityViewHolder(private var binding: ItemCustomerBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(customer: CustomerEntity) {
            binding.customer = customer
            binding.executePendingBindings()
        }
    }

    companion object DiffCallback : DiffUtil.ItemCallback<CustomerEntity>() {
        override fun areItemsTheSame(oldItem: CustomerEntity, newItem: CustomerEntity): Boolean {
            return oldItem.idKH == newItem.idKH
        }

        override fun areContentsTheSame(oldItem: CustomerEntity, newItem: CustomerEntity): Boolean {
            return oldItem == newItem
        }
    }
}