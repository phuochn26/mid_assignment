import React from "react";
import {
    Link
  } from "react-router-dom";
import "./Category.css"

const CreateCategory = () => {
    return (
        <div>
            <div>
                <h3 class="d-inline-block">Create Book</h3>
              <Link to="/category">Back to list</Link>
            </div>
            <div>
                <div>
                    <label>Category Name</label>
                    <input type="text"></input>
                </div>
            </div>
        </div>
    )
}

export default CreateCategory;