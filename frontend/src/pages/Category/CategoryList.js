import React from "react";
import {
    Link
  } from "react-router-dom";
import "./Category.css"

const CategoryList = () => {
    return (
        <div>
        <div style={{ marginBottom: '10px' }}>
            <h3 class="d-inline-block">Category list</h3>
            <Link to={"/createCategory"} >Add new category</Link>
        </div>
        <div>
            <table>
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Action</td>
                        <td><Link>Edit</Link><Link style={{ marginLeft: '10px' }}>Delete</Link></td>
                    </tr>
                    <tr>
                        <td>Drama</td>
                        <td><Link>Edit</Link><Link style={{ marginLeft: '10px' }}>Delete</Link></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    )
}

export default CategoryList;