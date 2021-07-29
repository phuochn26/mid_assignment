import React from "react";
import "./LoginPage.css"

const LoginPage = () => {
    return (
        <div>
            <h1 style={{ textAlign: 'center' }} >Login Form</h1>
            <div>
                <form>
                    <div>
                        <label>UserName</label><br />
                        <input type="text" />
                    </div>
                    <div>
                        <label>Password</label><br />
                        <input type="password" />
                    </div>
                    <div>
                        <button type="submit">
                            Submit
                        </button>
                    </div>
                </form>
            </div>
        </div>
    )
}

export default LoginPage;