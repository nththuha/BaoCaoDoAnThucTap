package com.example.ordermanagement.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.ordermanagement.R
import com.example.ordermanagement.databinding.ItemRoomBinding
import com.example.ordermanagement.model.RoomEntity

class RoomAdapter(private val clickListener: (RoomEntity) -> Unit) :
    ListAdapter<RoomEntity, RoomAdapter.RoomEntityViewHolder>(DiffCallback) {
    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): RoomAdapter.RoomEntityViewHolder {
        val viewHolder = RoomEntityViewHolder(
            ItemRoomBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
        viewHolder.itemView.setOnClickListener {
            val position = viewHolder.adapterPosition
            clickListener(getItem(position))
        }
        return viewHolder
    }

    override fun onBindViewHolder(holder: RoomAdapter.RoomEntityViewHolder, position: Int) {
        val room = getItem(position)
        holder.bind(room)
    }

    class RoomEntityViewHolder(private var binding: ItemRoomBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(room: RoomEntity) {
            if (room.trangThai == "Unavailable") {
                binding.llRoom.setBackgroundResource(R.drawable.btn_room_unavailable)
                binding.llRoom.isEnabled = false;
            }
            binding.room = room
            binding.executePendingBindings()
        }
    }

    companion object DiffCallback : DiffUtil.ItemCallback<RoomEntity>() {
        override fun areItemsTheSame(oldItem: RoomEntity, newItem: RoomEntity): Boolean {
            return oldItem.maPhong == newItem.maPhong
        }

        override fun areContentsTheSame(oldItem: RoomEntity, newItem: RoomEntity): Boolean {
            return oldItem == newItem
        }
    }
}